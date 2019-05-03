package com.pera.perakasa;

import android.content.Intent;
import android.os.AsyncTask;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

import static java.sql.DriverManager.println;

public class Giris extends AsyncTask< String, String, String > {

    MainActivity _act;

    Connection con;
    String mesaj;
    Boolean basariliMi;

    public Giris(MainActivity mainActivity) {
        this._act = mainActivity;
    }

    @Override
    protected void onPreExecute() {
        println("On PRE Execute Started");
    }

    @Override
    protected void onPostExecute(String res) {
        println("On POST Execute Started");
        Toast.makeText(_act.getApplicationContext(), res, Toast.LENGTH_SHORT).show();
        if (basariliMi){
            Toast.makeText(_act.getApplicationContext(),"Giriş Başarılı", Toast.LENGTH_LONG).show();
            //finish()
        }
    }

    @Override
    protected String doInBackground(String... strings) {

        //String user = _act.txtKulAdi.getText().toString();
        //String pw = _act.txtSifre.getText().toString();

        String user = "64801285622";
        String pw = "5emrends";

        try {
            ConnectionClass connectionClass = new ConnectionClass();

            con = connectionClass.baglanti();
            if (con == null){
                mesaj = "Bağlantınızı kontrol edin.";
            }
            else{
                String sorgu = "SELECT * FROM Calisans WHERE TCNo='"+user+"' AND Sifre='"+pw+"';";
                Statement durum = con.createStatement();
                ResultSet rs = durum.executeQuery(sorgu);

                if( rs.next()){
                    mesaj = "Giriş Başarılı";
                    basariliMi = true;
                    con.close();

                    try {
                        Intent k = new Intent(_act.getApplicationContext(), MainMenuActivity.class);
                        _act.startActivity(k);
                    } catch (Exception e) {
                        e.printStackTrace();
                    }


                }else{
                    mesaj = "Kullanıcı bulunamadı.";
                    basariliMi = false;
                    con.close();
                }
            }
        }catch (Exception e){
            basariliMi = false;
            mesaj=e.getLocalizedMessage();
            System.out.println("Sorun (exception olustu) : " + e.getLocalizedMessage());
        }

        return mesaj;
    }
}
