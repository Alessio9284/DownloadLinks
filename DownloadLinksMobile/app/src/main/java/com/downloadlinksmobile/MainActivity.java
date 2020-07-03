package com.downloadlinksmobile;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;

public class MainActivity extends AppCompatActivity {
    private static final int PICKFILE_REQUEST_CODE = 100;
    private String dest;
    private boolean save;

    private String url;
    private String radice;
    private String estensione;
    private String da;
    private String a;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        save = false;
        setContentView(R.layout.activity_main);
    }

    public void destinatione(View v) {
        Intent i = new Intent(Intent.ACTION_OPEN_DOCUMENT_TREE);
        i.addCategory(Intent.CATEGORY_DEFAULT);
        startActivityForResult(Intent.createChooser(i, "Scegli Cartella"), PICKFILE_REQUEST_CODE);
    }

    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == PICKFILE_REQUEST_CODE) {
            dest = data.getDataString();
            save = true;
        }
    }
}