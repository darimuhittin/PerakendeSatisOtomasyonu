package com.pera.perakasa

import android.content.Intent
import android.os.AsyncTask
import android.view.View
import android.widget.Toast
import java.lang.Exception
import java.sql.ResultSet
import java.sql.Statement
import java.sql.Connection

class Giris(val _act:MainActivity): AsyncTask<String, String, String>(){

    private lateinit var calisan:Calisan
    private lateinit var con: Connection

    var mesaj:String=""
    var basariliMi:Boolean=false

    override fun onPreExecute() {
        println("On PRE Execute Started")
        _act.islemCubugu.visibility = View.VISIBLE
    }

    override fun onPostExecute(result: String?) {

        println("On POST Execute Started")
        _act.islemCubugu.visibility = View.GONE
        Toast.makeText(_act.applicationContext, result, Toast.LENGTH_SHORT).show()
        if (basariliMi){
            Toast.makeText(_act.applicationContext,"Giriş Başarılı", Toast.LENGTH_LONG).show()

            //finish()
        }
    }

    override fun doInBackground(vararg params: String?): String {
        val kadi:String = _act::txtKulAdi.get().text.toString()
        val sifre:String = _act::txtSifre.get().text.toString()

        if (kadi.trim().equals("") || sifre.trim().equals(""))
            mesaj = "Kullanıcı adı ve şifre giriniz !"
        else{
            try {
                val connectionClass = ConnectionClass()

                con = connectionClass.baglanti()
                if (con == null){
                    mesaj = "Bağlantınızı kontrol edin."
                }
                else{
                    val sorgu:String = "SELECT * FROM Calisans WHERE TCNo='"+kadi+"' AND Sifre='"+sifre+"';"
                    val durum: Statement = con.createStatement()
                    val rs: ResultSet = durum.executeQuery(sorgu)

                    if( rs.next()){

                        val kulId:Int = rs.getInt("ID")
                        val kulTc:String = rs.getString("TCNo")
                        val kulSifre:String = rs.getString("Sifre")
                        val kulAd:String = rs.getString("Ad")
                        val kulSoyad:String = rs.getString("Soyad")
                        val kulTelNo:String = rs.getString("TelNo")
                        val kulMail:String = rs.getString("Mail")
                        val kulPozisyon:String = rs.getString("Pozisyon")
                        val kulYetki:Boolean = rs.getBoolean("Yetki")
                        val kulMaas:Float = rs.getFloat("Maas")

                        println(kulId)
                        println(kulTc)
                        println(kulSifre)
                        println(kulAd)
                        println(kulSoyad)
                        println(kulTelNo)
                        println(kulMail)
                        println(kulPozisyon)
                        println(kulYetki)
                        println(kulMaas)

                        calisan = Calisan(kulId,kulTc,kulSifre,kulAd,kulSoyad,kulTelNo,kulMail,kulPozisyon,kulYetki,kulMaas)

                        mesaj = "Giriş Başarılı"
                        basariliMi = true
                        con.close()

                        try {
                            val k = Intent(_act.applicationContext, MainMenuActivity::class.java)
                            _act.startActivity(k)
                        } catch (e: Exception) {
                            e.printStackTrace()
                        }


                    }else{
                        mesaj = "Kullanıcı bulunamadı."
                        basariliMi = false
                        con.close()
                    }
                }
            }catch (e: Exception){
                basariliMi = false
                mesaj=e.localizedMessage
                print("Sorun (exception olustu) : " + e.localizedMessage)
            }
        }

        return mesaj
    }

}