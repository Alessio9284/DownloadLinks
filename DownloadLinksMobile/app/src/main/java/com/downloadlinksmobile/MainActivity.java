package com.downloadlinksmobile;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {
    private static final int DIR_REQUEST_CODE = 100;
    private String dest;
    private boolean save;

    private String url;
    private String radice;
    private String estensione;
    private String da;
    private String a;

    private Button b, b1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        save = false;
        b = findViewById(R.id.des);
        b1 = findViewById(R.id.dow);

        setContentView(R.layout.activity_main);

        b.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                /*Intent i = new Intent(Intent.ACTION_OPEN_DOCUMENT_TREE);
                i.addCategory(Intent.CATEGORY_DEFAULT);
                startActivityForResult(Intent.createChooser(i, "Scegli Cartella"), DIR_REQUEST_CODE);*/
            }
        });

        b1.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {

            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == DIR_REQUEST_CODE) {
            dest = data.getDataString();
            save = true;
            b.setBackgroundColor(Color.GREEN);
        }
    }
}