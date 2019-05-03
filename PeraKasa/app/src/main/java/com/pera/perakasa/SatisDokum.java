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

import org.w3c.dom.Text;

import java.math.BigDecimal;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class SatisDokum extends Activity {

    ArrayList<String> satisListesi = new ArrayList<>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Intent intent = getIntent();
        satisListesi = intent.getStringArrayListExtra("satisListesi");
        super.onCreate(savedInstanceState);
        requestWindowFeature ( Window.FEATURE_NO_TITLE );
        setContentView(R.layout.activity_satis_dokum);
        DBIslem dbi = new DBIslem(this);
        dbi.execute (satisListesi);
    }



}
