package com.pera.perakasa;

import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.util.Log;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionClass {

    private String ip = "192.168.1.27";
    private String classs = "net.sourceforge.jtds.jdbc.Driver";
    private String db = "dbPera";
    private String un = "dari";
    private String password = "5emrends";


    Connection baglanti() {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Connection conn = null;
        String ConnURL;

        try {
            Class.forName(classs);
            ConnURL = ("jdbc:jtds:sqlserver://" + ip + ";"
                    + "databaseName=" + db + ";user=" + un + ";password="
                    + password + ";");
            conn = DriverManager.getConnection(ConnURL);
        } catch (SQLException se) {
            Log.e("ERRO", se.getLocalizedMessage());
        } catch (ClassNotFoundException e) {
            Log.e("ERRO", e.getLocalizedMessage());
        } catch (Exception e) {
            Log.e("ERRO", e.getLocalizedMessage());
        }
        return conn;
    }
}
