package com.pera.perakasa;

import android.content.Context;
import android.os.AsyncTask;
import android.widget.Toast;

import net.sourceforge.jtds.jdbc.DateTime;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Timestamp;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;

public
class SatisKayit extends AsyncTask<String,String,String> {

    private HashMap<String,BigDecimal> satisMap = new HashMap <> ();
    private Context mContext;

    public SatisKayit(HashMap<String,BigDecimal> pSatisMap,Context pContext){
        this.satisMap = pSatisMap;
        this.mContext = pContext;
    }

    @Override
    protected
    void onPreExecute ( ) {
        super.onPreExecute ( );
    }

    @Override
    protected
    String doInBackground ( String... odemeYontemiParams ) {
        String odemeYontemi = odemeYontemiParams[0];
        try {

            ConnectionClass connectionClass = new ConnectionClass ( );
            Connection con = connectionClass.baglanti ( );
            Statement st = con.createStatement ();
            if ( con == null ) {
                Toast.makeText ( mContext,"Bağlantınızı kontrol edin.",Toast.LENGTH_SHORT );
            }
            else {
                Timestamp tarih = new Timestamp (System.currentTimeMillis ());
                BigDecimal tutar = BigDecimal.valueOf ( 0 );
                int magazaId = 1;
                int musteriId = 1;
                for ( BigDecimal parcaUrunFiyat:satisMap.values () ) {
                    tutar = tutar.add ( parcaUrunFiyat );
                }
                String kayitQuery = "INSERT INTO Satis VALUES ('"+tarih+"',"+tutar+",'"+odemeYontemi+"',"+magazaId+","+musteriId+");";
                st.executeQuery ( kayitQuery );


                /*
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
                */
                con.close ( );
            }
        }
        catch ( SQLException e1 ) {
            e1.printStackTrace ( );
        }
        catch ( Exception e ) {
            System.out.println ( "Sorun (exception olustu) : " + e.getLocalizedMessage ( ) );
        }
        return null;
    }

    @Override
    protected
    void onPostExecute ( String s ) {
        super.onPostExecute ( s );
    }

}
