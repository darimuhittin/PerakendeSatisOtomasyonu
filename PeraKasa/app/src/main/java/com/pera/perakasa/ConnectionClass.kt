package com.pera.perakasa

import android.annotation.SuppressLint
import android.os.StrictMode
import android.util.Log
import java.sql.Connection
import java.sql.DriverManager
import java.sql.SQLException

@SuppressLint("NewApi")
class ConnectionClass {
    private var ip = "192.168.1.27"
    private var classs = "net.sourceforge.jtds.jdbc.Driver"
    private var db = "dbPera"
    private var un = "dari"
    private var password = "5emrends"


    @SuppressLint("NewApi")
    fun baglanti(): Connection {
        val policy = StrictMode.ThreadPolicy.Builder()
            .permitAll().build()
        StrictMode.setThreadPolicy(policy)
        lateinit var conn: Connection
        var ConnURL: String? = null

        try {
            Class.forName(classs)
            ConnURL = ("jdbc:jtds:sqlserver://" + ip + ";"
                    + "databaseName=" + db + ";user=" + un + ";password="
                    + password + ";")
            conn = DriverManager.getConnection(ConnURL)
        } catch (se: SQLException) {
            Log.e("ERRO", se.message)
        } catch (e: ClassNotFoundException) {
            Log.e("ERRO", e.message)
        } catch (e: Exception) {
            Log.e("ERRO", e.message)
        }

        return conn
    }
}
