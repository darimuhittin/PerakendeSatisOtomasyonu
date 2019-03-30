package com.pera.perakasa

import android.content.Intent
import android.os.AsyncTask
import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.ProgressBar
import android.widget.Toast
import org.w3c.dom.Text
import java.lang.Exception
import java.sql.Connection
import java.sql.ResultSet
import java.sql.Statement


class MainActivity : AppCompatActivity(),View.OnClickListener {

    private lateinit var btnGiris:Button
    private lateinit var txtKulAdi:EditText
    private lateinit var txtSifre:EditText
    private lateinit var islemCubugu:ProgressBar
    private lateinit var con:Connection


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        btnGiris = findViewById<Button>(R.id.btnGiris)
        btnGiris.setOnClickListener(this)
        txtKulAdi = findViewById<EditText>(R.id.ptKullaniciAdi)
        txtSifre = findViewById<EditText>(R.id.pwSifre)
        islemCubugu = findViewById<ProgressBar>(R.id.pbIslemCubugu)
        islemCubugu.visibility = View.GONE

    }


    override fun onClick(v: View?) {
        if (v != null) {
            if (v.id == btnGiris.id)
            {
                val baglantiKontrolEt = GirisKontrol()
                baglantiKontrolEt.execute("")
            }

        }
    }

    inner class GirisKontrol: AsyncTask<String, String, String>(){

        var mesaj:String=""
        var basariliMi:Boolean=false

        override fun onPreExecute() {
            islemCubugu.visibility=View.VISIBLE
        }

        override fun onPostExecute(result: String?) {
            islemCubugu.visibility = View.GONE
            Toast.makeText(this@MainActivity, result, Toast.LENGTH_SHORT).show()
            if (basariliMi){
                Toast.makeText(this@MainActivity,"Giriş Başarılı",Toast.LENGTH_LONG).show()

                //finish()
            }
        }

        override fun doInBackground(vararg params: String?): String {
            val kadi:String = txtKulAdi.text.toString()
            val sifre:String = txtSifre.text.toString()

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
                        val sorgu:String = "SELECT * FROM Calisans"
                        val durum:Statement = con.createStatement()
                        val rs:ResultSet = durum.executeQuery(sorgu)

                        if(rs.next()){
                            mesaj = "Giriş Başarılı"
                            basariliMi = true
                            con.close()
                        }else{
                            mesaj = "Kullanıcı bulunamadı."
                            basariliMi = false
                            con.close()
                        }
                    }
                }catch (e:Exception){
                    basariliMi = false
                    mesaj=e.localizedMessage
                    print("Sorun (exception olustu) : " + e.localizedMessage)
                }
            }

            return mesaj
        }

    }


}