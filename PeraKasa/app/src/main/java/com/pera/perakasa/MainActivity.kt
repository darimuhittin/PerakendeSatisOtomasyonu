package com.pera.perakasa

import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.ProgressBar


class MainActivity : AppCompatActivity(),View.OnClickListener {

    private lateinit var btnGiris:Button


    lateinit var txtKulAdi: EditText
    lateinit var txtSifre: EditText
    lateinit var islemCubugu: ProgressBar


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
                val baglantiKontrolEt = Giris(this)
                baglantiKontrolEt.execute("")
            }

        }
    }




}