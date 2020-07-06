package com.downloadlinksmobile;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.ProgressBar;
import android.widget.TextView;

import java.io.BufferedInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.URL;
import java.net.URLConnection;

public class MainActivity extends AppCompatActivity {
    private static final int DIR_REQUEST_CODE = 100;
    private String dest, nomefile;
    private boolean save;

    private Button destination, download;
    private TextView url, rad, ext, from, to;
    private CheckBox cb;
    private ProgressBar pb;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        save = false;
        destination = this.findViewById(R.id.des);
        download = this.findViewById(R.id.dow);
        url = this.findViewById(R.id.url);
        rad = this.findViewById(R.id.rad);
        ext = this.findViewById(R.id.ext);
        from = this.findViewById(R.id.da);
        to = this.findViewById(R.id.a);
        cb = this.findViewById(R.id.check);
        pb = this.findViewById(R.id.pro);

        destination.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(Intent.ACTION_OPEN_DOCUMENT_TREE);
                i.addCategory(Intent.CATEGORY_DEFAULT);
                startActivityForResult(Intent.createChooser(i, "Scegli Cartella"), DIR_REQUEST_CODE);
            }
        });

        download.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int da = Integer.parseInt(from.getText().toString());
                int a = Integer.parseInt(to.getText().toString());

                for (int i = da; i <= a; i++)
                    start_download(i);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == DIR_REQUEST_CODE) {
            dest = data.getDataString();
            save = true;
            destination.setBackgroundColor(Color.GREEN);
        }
    }

    private void start_download(int i) {
        int num;

        nomefile = rad.getText().toString();

        if (cb.isChecked())
        {
            num = (int) (Math.floor(Math.log(Integer.parseInt(to.getText().toString())) / Math.log(10.0)) - Math.floor(Math.log(i) / Math.log(10.0)));

            for(int x = 0; x < num; x++) nomefile += "0";
        }

        nomefile = i + ext.getText().toString();

        int count;
        try {
            URL url_ = new URL(url.getText().toString());
            URLConnection connection = url_.openConnection();
            connection.connect();

            // this will be useful so that you can show a tipical 0-100%
            // progress bar
            int lenghtOfFile = connection.getContentLength();

            // download the file
            InputStream input = new BufferedInputStream(url_.openStream(), 8192);

            // Output stream
            OutputStream output = new FileOutputStream(dest + nomefile);

            byte data[] = new byte[1024];

            long total = 0;

            while ((count = input.read(data)) != -1) {
                total += count;
                // publishing the progress....
                // After this onProgressUpdate will be called
                pb.setProgress((int) ((total * 100) / lenghtOfFile));

                // writing data to file
                output.write(data, 0, count);
            }

            // flushing output
            output.flush();

            // closing streams
            output.close();
            input.close();

        } catch (Exception e) {
            Log.e("Error: ", e.getMessage());
        }
    }
}