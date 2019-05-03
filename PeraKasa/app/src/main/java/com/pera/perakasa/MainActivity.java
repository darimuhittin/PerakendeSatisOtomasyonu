package com.pera.perakasa;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;

public class MainActivity extends Activity implements View.OnClickListener {


    Button btnGiris;

    EditText txtKulAdi;
    EditText txtSifre;
    ProgressBar islemCubugu;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature ( Window.FEATURE_NO_TITLE );
        setContentView(R.layout.activity_main);

        btnGiris = findViewById(R.id.btnGiris);
        btnGiris.setOnClickListener(this);
        txtKulAdi = findViewById(R.id.ptKullaniciAdi);
        txtSifre = findViewById(R.id.pwSifre);
        islemCubugu = findViewById(R.id.pbIslemCubugu);
        islemCubugu.setVisibility(View.GONE);
    }

    @Override
    public void onClick(View v) {
        if (v != null) {
            if (v.getId() == btnGiris.getId());
            {
                Giris baglantiKontrolEt = new Giris(this);
                baglantiKontrolEt.execute("");
            }

        }
    }
}
