using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class moves : MonoBehaviour {
    Animator Player;
    void Start()
    {
        Player = GetComponent<Animator>();
    }    
   
    void Update () {
        ConsoleKeyInfo Keys;
        //do
        //{
            Keys = Console.ReadKey();

            switch (Keys.Key)
            {
                case ConsoleKey.UpArrow:
                    Player.Play("Jump");
                    break;
            }
        //} while ();



       /*if()
        {
            Player.Play("Jump");
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Player.Play("Couch");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Player.Play("Walk");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            do {
                Player.Play("Run");
            }while()
            
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Player.Play("Idle");
        }*/
    }
}
