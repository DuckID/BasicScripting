﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour 
{
	Karakter player1;
	void Start ()
	{
		player1 = new Karakter ();
		player1.Name = "Dico";
		player1.Health = 100;
		player1.Damage = 30;
		//Menampilkan hasil dari inisialisasi attribute
		Debug.Log ("Name : " + player1.Name + ", Health: " + player1.Health + ", Damage: " + player1.Damage);

		//Memanggil method dari salah satu method di Karakter.
		player1.Jump ();
	}

	void Update () {
		
	}
}
