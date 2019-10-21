package com.iesnervion.equiposnba;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.TextView;

import java.util.ArrayList;

//Hay que implementar un TextWatcher.
public class MainActivity extends AppCompatActivity implements TextWatcher, AdapterView.OnItemSelectedListener {
    private TextView label;
    private AutoCompleteTextView edit;
    private static final String[] items = {"Black Bulls", "Golden Dawn","Green Mantis","Crimson Lion", "Azure Deer", "Blue Rose", "Coral Peacock","Purple Orca", "Silver Eagles"};
    //Los items que contendrá el Spinner.
    private static ArrayList<String> itemsSpinner = new ArrayList<>();

    Spinner spinner;
    ArrayAdapter<String> aa;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        label = findViewById(R.id.label);
        spinner = findViewById(R.id.spinner);
        spinner.setOnItemSelectedListener(this);

        //Contenido que va a mostrar el Spinner
        aa = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, itemsSpinner);
        //Especifica el diseño que debe usar el adaptador.
        aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        //Aplica el adaptador al Spinner
        spinner.setAdapter(aa);

        //Buscamos el AutoCompleteTextView
        edit =  findViewById(R.id.edit);
        edit.addTextChangedListener(this);
        //edit.setAdapter(new ArrayAdapter<>(this, android.R.layout.simple_dropdown_item_1line, items));
        edit.setAdapter(new IconicAdapter<String>(this, R.layout.rows, R.id.label,items));
    }

    /*
     * Añade en tiempo de ejecucion el contenido que halla en el AutoCompleteTextView y lo añade a un Spinner,
     * solo si hay menos de 4 elementos dentro.
     * */
    public void anadirElementoASpinner(View v){
        if(itemsSpinner.size() < 4){
            itemsSpinner.add(this.edit.getEditableText().toString()); //Tambien podia añadirlo directamente al spinner
            //Para que se actualicen los cambios.
            aa.notifyDataSetChanged();
        }else{
           label.setVisibility(View.VISIBLE);
        }
    }


    /*
    * Limpia los campos introducidos en el Spinner y establece el texto de error a su valor por defecto (Invisible).
    * */
    public void limpiarCampos(View v){
        label.setVisibility(View.INVISIBLE);
        aa.clear();
    }

    //Metodos para el AutoCompleteTextView
    public void onTextChanged(CharSequence s, int start, int before, int count){

    }

    public void beforeTextChanged(CharSequence s, int start, int count, int after){
        //Necesitado para la interfaz.
    }

    public void afterTextChanged(Editable s){
        //Necesitado para la interfaz.
    }


    //Metodos para el spinner
    public void onItemSelected(AdapterView parent, View v, int position, long id){

    }

    public void onNothingSelected(AdapterView parent){

    }

    //Clase IcononicAdapter
    class IconicAdapter<T> extends ArrayAdapter<T>{
        IconicAdapter(Context c, int resourceId, int textId, T[] objects){
            super(c, resourceId, textId, objects);
        }

        public View getView(int position, View convertView, ViewGroup parent){
            View row = super.getView(position, convertView, parent);

            ImageView icon = row.findViewById(R.id.icono);
            //Obtenemos el item que queremos
            Object item = edit.getAdapter().getItem(position);

            switch(item.toString()){
                case "Black Bulls":
                    icon.setImageResource(R.drawable.blackbull);
                    break;
                case "Golden Dawn":
                    icon.setImageResource(R.drawable.goldendawn);
                    break;
                case "Green Mantis":
                    icon.setImageResource(R.drawable.mantisverdes);
                    break;
                case "Crimson Lion":
                    icon.setImageResource(R.drawable.crimsonlion);
                    break;
                case "Azure Deer":
                    icon.setImageResource(R.drawable.ciervosazules);
                    break;
                case "Purple Orca":
                    icon.setImageResource(R.drawable.orcasmoradas);
                    break;
                case "Silver Eagles":
                    icon.setImageResource(R.drawable.aguilas);
                    break;
                case "Blue Rose":
                    icon.setImageResource(R.drawable.bluerose);
                    break;
                case "Coral Peacock":
                    icon.setImageResource(R.drawable.pavoscoral);
                    break;


            }

            return row;
        }
    }

}
