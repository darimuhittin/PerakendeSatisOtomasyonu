package com.pera.perakasa;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.Window;

import java.math.BigDecimal;
import java.util.HashMap;

public
class OdemeYontemiSecActivity extends AppCompatActivity {

    private HashMap<String,BigDecimal> satisMap;

    public OdemeYontemiSecActivity(){

    }
    @Override
    protected
    void onCreate ( Bundle savedInstanceState ) {
        super.onCreate ( savedInstanceState );
        Intent in = getIntent ();
        HashMap<String,BigDecimal> pSatisMap = (HashMap < String, BigDecimal >) in.getSerializableExtra ( "map" );
        this.satisMap = pSatisMap;
        requestWindowFeature ( Window.FEATURE_NO_TITLE );
        setContentView ( R.layout.activity_odeme_yontemi_sec );
    }

    public void odemeKaydetKredi(View v) {
        satisKayit("Kredi");
    }

    private
    void satisKayit ( String odemeYontemi ) {
        SatisKayit sk = new SatisKayit ( satisMap ,this);
        sk.execute ( odemeYontemi );
    }

    void odemeKaydetNakit ( View view ){
        satisKayit("Nakit");
    }

}
