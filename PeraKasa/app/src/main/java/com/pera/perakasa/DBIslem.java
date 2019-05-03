package com.pera.perakasa;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Color;
import android.os.AsyncTask;
import android.view.Gravity;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;

import static java.sql.DriverManager.println;

public
class DBIslem extends AsyncTask < ArrayList < String >, String, HashMap > {

    @SuppressLint("StaticFieldLeak")
    private SatisDokum _act;

    private String                         mesaj;
    private Boolean                        basariliMi;
    private HashMap < String, BigDecimal > map;
    private ArrayList<String>              satisList;
    DBIslem ( SatisDokum satisDokumAct ) {
        this._act = satisDokumAct;
    }

    @SafeVarargs
    @Override
    protected final
    HashMap doInBackground ( ArrayList < String >... pSatisList ) {
        try {
            satisList = pSatisList[0];
            map = new HashMap <> ( );
            ConnectionClass connectionClass = new ConnectionClass ( );

            Connection con = connectionClass.baglanti ( );
            if ( con == null ) {
                mesaj = "Bağlantınızı kontrol edin.";
            }
            else {
                basariliMi = true;

                for ( String bark : satisList) {
                    //DB FİYAT ÇEKME
                    String     sorgu    = "SELECT * FROM Uruns WHERE BarkodNo ='" + bark + "' ;";
                    Statement  durum    = con.createStatement ( );
                    ResultSet  rs       = durum.executeQuery ( sorgu );
                    BigDecimal fiyatDec = BigDecimal.valueOf ( 0 );
                    if ( rs.next ( ) ) {
                        fiyatDec = rs.getBigDecimal ( "Fiyat" );
                    }
                    map.put ( bark , fiyatDec );
                    // DB FİYAT ÇEKME SON
                }
                con.close ( );
            }
        }
        catch ( SQLException e1 ) {
            e1.printStackTrace ( );
        }
        catch ( Exception e ) {
            basariliMi = false;
            mesaj = e.getLocalizedMessage ( );
            System.out.println ( "Sorun (exception olustu) : " + e.getLocalizedMessage ( ) );
        }

        return map;
    }

    @Override
    protected
    void onPreExecute ( ) {
        println ( "DBIslem On PRE Execute Started" );
    }


    @Override
    protected
    void onPostExecute ( HashMap resMap ) {
        println ( "DBIslem On POST Execute Started" );
        if ( basariliMi ) {
            Toast.makeText ( _act.getApplicationContext ( ) , mesaj , Toast.LENGTH_LONG ).show ( );

            //SATIŞ LİSTESİ DOLDUR
            for (int i=0;i<satisList.size ();i++ ){
                TableLayout t1     = _act.findViewById ( R.id.tblSatisDokumu );
                TableRow    r1     = new TableRow ( _act.getApplicationContext ( ) );
                TextView    barkod = new TextView ( _act.getApplicationContext ( ) );
                TextView    miktar = new TextView ( _act.getApplicationContext ( ) );
                TextView    fiyat  = new TextView ( _act.getApplicationContext ( ) );

                TableRow.LayoutParams paramBarkod = new TableRow.LayoutParams
                        (
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                4.0f
                        );

                TableRow.LayoutParams paramMiktar = new TableRow.LayoutParams
                        (
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                2.0f
                        );


                TableRow.LayoutParams paramFiyat = new TableRow.LayoutParams
                        (
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                TableRow.LayoutParams.WRAP_CONTENT ,
                                2.0f
                        );

                //BARKOD
                String bark = satisList.get ( i );
                barkod.setText ( bark);
                barkod.setLayoutParams ( paramBarkod );
                barkod.setGravity ( Gravity.CENTER );
                barkod.setTextSize ( 14 );
                barkod.setTextColor ( Color.BLACK );
                barkod.setBackgroundColor ( Color.rgb ( 130 , 177 , 255 ) );

                //MİKTAR SET
                String mik = "1";
                miktar.setLayoutParams ( paramMiktar );
                miktar.setGravity ( Gravity.CENTER );
                miktar.setTextColor ( Color.BLACK );
                miktar.setBackgroundColor ( Color.rgb ( 195 , 185 , 235 ) );
                miktar.setTextSize ( 14 );
                miktar.setText ( mik );

                //FİYAT SET
                String fiyatDeger = String.valueOf ( resMap.get ( bark) );

                if ( fiyatDeger == "0" ){ //YANLIŞ OKUNAN DEĞERLER İÇİN
                    continue;
                }

                fiyat.setText (fiyatDeger);
                fiyat.setLayoutParams ( paramFiyat );
                fiyat.setGravity ( Gravity.CENTER );
                fiyat.setTextColor ( Color.BLACK );
                fiyat.setBackgroundColor ( Color.rgb ( 167 , 155 , 235 ) );
                fiyat.setTextSize ( 14 );

                r1.addView ( barkod );
                r1.addView ( miktar );
                r1.addView ( fiyat );
                t1.addView ( r1 );
            }
            // SATIŞ LİSTESİ DOLDUR SON
        }
    }
}