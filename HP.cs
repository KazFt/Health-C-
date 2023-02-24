
using System.Collections;
using System.Collections.Generic;

//this up here is not something to touch, Im basically new to C# so I have no idea what that is.

//For Information about this script scroll down to the end to see more comments.


//HP Script

int MaxHP = 100;
int MinHP = 0;

//Function that will make the code work
private void start(){

    Debug.log("Increasing Health");
    StartCoroutine(PlayerHealth);

}

IEnumerator PlayerHealth(){
    //Generating HP
    for(int i = 1; i <= MaxHP; i++){
        
        MinHP = i;
        yield return new WaitForSeconds(0.2f);
        Debug.log("HP: " + MinHP + "/" + MaxHP);
    }
    //show up that your health is full/or not.
    Debug.log("Health now: " + MaxHP);
}

//Power

float MaxPower = 10.0f;
float MinPower = 0.0f;

IEnumerator PlayerPower(){
    //Generating Power
    for(int c = 0.1; x <= MaxPower; c++){ 

        MinPower = c++
        yield return new WaitForSeconds(0.08f)
        debug.log("Power: " + MinPower + "/" + MaxPower);
    }
    //Show up that your power is full/or not.
    Debug.log("Power now: " + MaxPower);
}

//Information-

/*
    -This is basically a HP and Power generation, this is won't work in-game, but it will work in the console.
    -How to see this in the console? Follow this step below.(Unity Only)

    -NOTE-
    -Make sure you got Microsoft Visual Studio.

    1)(In Windows) Go to Unity Editor and on the top right click "Edit".
    2)Find Preferences and click on "External Tools".
    3)Then change "External Script Editor" option to Microsoft Visual Studio.
    ----------------------------------------
    4) In Unity Editor, you create a C# file.
    5)Then double click the file to open it.
    6)Dont delete "Public class" in Visual studio, even the "Using UnityEngine" and above it.
    7)Delete only the code that been written in "Public class".
    8)Copy and paste the written code above, starting from "/HP script".

    //I hope you understand those steps, if you don't, then I dont what to say to you.
    //Remember this is won't do anything in your game project, this will only do to the console, it will output a generated HP and Powers.
    

    -Kaz Was here :)
*/