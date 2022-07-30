using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
	
	//Local one as coisas irão ser teletransportadas.
	public Transform local;

	//Propriedade concernente a posição do Jogador.
	public Transform eu;
	public Transform you;

	//Objectos usados no jogos pra alcançar certas metas e pontuações.
	public Transform Esfera;
	public Transform Esfera1;
	public Transform Esfera2;

	public bool transporte;

	// Use this for initialization
	void Start () {
	}

	void Update()
	{
		
	}

	//Para Jogadores
	void OnCollisionEnter2D (Collision2D other)
	{
		//Se o portal que tem esse script colidir com Player.
		if (other.transform.tag == "Player")
		{
			//Então a propriedade de posicão do Player vai receber a propriedade de posição do local.
			eu.transform.position = local.transform.position;
			print ("Player");
		}
			//O mesmo vale pra o segundo Player porque têm a mesma tag.
		else if (other.transform.tag == "Player2")
		{
			you.transform.position = local.transform.position;
		}

	}

	//Para Objectos
	//Se o portal colidir com algumas das balls, a mesma será teletransportada.
	void OnCollisionStay2D (Collision2D sphere)
	{
		//Se o portal colidir com alguma esfera.
		//A esfera com taga referente vai receber a propriedade de posição do local onde será tele...
		switch (sphere.transform.tag)
		{
			case  "Obj":
			Esfera.transform.position = local.transform.position;
			print ("Obj");
			break;

			case  "Obj2":
			Esfera1.transform.position = local.transform.position;
			print ("Obj2");
			break;

		case "Obj3":
			Esfera2.transform.position = local.transform.position;
			print ("Obj3");
			break;
		}
	}
}
