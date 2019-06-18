package com.pera.perakasa;

import android.Manifest;
import android.app.Activity;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.media.MediaPlayer;
import android.support.annotation.NonNull;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Toast;

import com.google.zxing.Result;

import java.util.ArrayList;

import me.dm7.barcodescanner.zxing.ZXingScannerView;

public class MainMenuActivity extends Activity implements ZXingScannerView.ResultHandler {

    private Kontrol k1 = new Kontrol();
    private ArrayList<String> satisListesiMain = new ArrayList<>();
    private static final int CAMERA_PERMISSION = 1888;
    private ZXingScannerView zXingScannerView;
    MediaPlayer mp;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature ( Window.FEATURE_NO_TITLE );
        setContentView(R.layout.activity_main_menu);
        mp = MediaPlayer.create(getApplicationContext (),R.raw.barcode);
        mp.setVolume(1.0f,1.0f);
        mp.start ();


    }

    public void tara(View view) {
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.CAMERA)
                != PackageManager.PERMISSION_GRANTED) {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.CAMERA}, CAMERA_PERMISSION);
        }else {
            zXingScannerView = new ZXingScannerView(this.getApplicationContext());
            setContentView(zXingScannerView);
            zXingScannerView.setResultHandler(this);
            zXingScannerView.startCamera();
        }
    }


    @Override
    protected void onPause() {
        super.onPause();
        if (zXingScannerView != null){
            zXingScannerView.stopCamera();
        }
    }


    public void anaEkranaDon(){
        zXingScannerView.stopCameraPreview ();
        zXingScannerView.stopCamera();
        setContentView(R.layout.activity_main_menu);
    }
    @Override
    public void onBackPressed() {
        if (zXingScannerView != null) {
            anaEkranaDon();
        }
        else
            super.onBackPressed();
    }


    @Override
    public void handleResult(Result rawResult) {
        mp.start();
        //Toast.makeText(getApplicationContext(),rawResult.getText(),Toast.LENGTH_SHORT).show();
        satisListesiMain.add(rawResult.getText());
        zXingScannerView.resumeCameraPreview(this);
    }


    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        switch (requestCode) {
            case CAMERA_PERMISSION:
                if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {

                } else {
                    Toast.makeText(this, "Barkod tarayıcıyı kullanabilmek için lütfen kamera izni veriniz.", Toast.LENGTH_SHORT).show();
                }
                return;
        }
    }

    public void satisDokumEkranGoruntule(View view){

        Intent intent = new Intent(this, SatisDokum.class);
        intent.putStringArrayListExtra("satisListesi",satisListesiMain);
        startActivity(intent);

    }




}
