package com.pera.perakasa;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Layout;
import android.view.Gravity;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;
import android.view.View;

import org.w3c.dom.Text;

import java.math.BigDecimal;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;

public class SatisDokum extends Activity {

    ArrayList<String> satisListesi = new ArrayList<>();
    HashMap<String,BigDecimal> satisMap = new HashMap <> ( );

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Intent intent = getIntent();
        satisListesi = intent.getStringArrayListExtra("satisListesi");
        //test
        satisListesi.add ( "1" );
        satisListesi.add ( "2" );
        satisListesi.add ( "3" );
        //test
        super.onCreate(savedInstanceState);
        requestWindowFeature ( Window.FEATURE_NO_TITLE );
        setContentView(R.layout.activity_satis_dokum);
        DBIslem dbi = new DBIslem(this);
        dbi.execute (satisListesi);

    }


    public void satisKayitOnClick (View view){
        OdemeYontemiSecActivity odemeYontemiSecActivity = new OdemeYontemiSecActivity ();
        Intent in = new Intent (this.getApplicationContext (),odemeYontemiSecActivity.getClass ());
        in.putExtra ("map",satisMap);
        startActivity (in);
    }

}
