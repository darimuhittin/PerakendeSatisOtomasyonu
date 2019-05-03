package com.pera.perakasa;
import android.util.Log;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class SQLDatabaseConnection {

    private String user,pw,db,server;

    private String connectionUrl;

    private Connection con;
    private ResultSet res;
    private Statement st;

    public SQLDatabaseConnection(){

        user = "dari;";
        pw = "5emrends;";
        server = "25.65.49.137:1433;";
        db = "dbPera;";

        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            //jdbc:jtds:sqlserver://MYPC:1433/Blog;instance=SQLEXPRESS;user=sa;password=s3cr3t
            connectionUrl = "jdbc:jtds:sqlserver://" + server+"databaseName="+db+"user="+user+"password="+pw;
            con = DriverManager.getConnection(connectionUrl);
        }
        catch (SQLException e) {
            Log.e("SQL Hata gerçekleşti : ",e.getMessage());
        }
        catch (ClassNotFoundException e){
            Log.e("Class Not Found Hata: ",e.getMessage());
        }
        catch (Exception e){
            Log.e("Hata gerçekleşti : ",e.getMessage());
        }
    }

    public void ac(){
        try {
            st = con.createStatement();
        }catch (Exception e){
            hataYaz(e);
        }
    }

    public void kapa(){
        try {
            if (!con.isClosed()){
                try {
                    con.close();
                } catch (SQLException e) {
                    e.printStackTrace();
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public ResultSet fiyatAlBarkod(String barkodNo){
        ac();

        String query = "SELECT Fiyat FROM Uruns WHERE BarkodNo = '"+barkodNo+"';";
        try {
            res = st.executeQuery(query);
        } catch (SQLException e) {
            e.printStackTrace();
            System.out.println("execute query hata.");
        }

        kapa();

        return res;
    }
    
    public void hataYaz(Exception e){
        System.out.println( "Hata Mesajı : "+e.getMessage());
    }
}