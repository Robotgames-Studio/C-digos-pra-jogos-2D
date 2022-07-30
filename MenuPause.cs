using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour {


	[Header("Objectos que serão ativados e desativados concernente ao menu de pausa")]
	public GameObject replayPause; //Button de Repetir a cena
	public GameObject proximoPause; //Button de carregar next scene
	public GameObject proximoFalse; //Button de carregar next scene falso ou seja sem função porque aqui estaremos apenas no modo pause e não podemos carregar já outra scene.
	public GameObject menuPause;   //Button de voltar no menu
	public GameObject descongelarBtn; //Button de tirar Pause.

	// Use this for initialization
	void Start () {

		//Desativar todos esses buttons quando a cena for carregada.
		replayPause.SetActive (false);
		proximoPause.SetActive (false);
		menuPause.SetActive (false);
		descongelarBtn.SetActive (false);
		proximoFalse.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {


		//Se você apertar Button Esc

		if (Input.GetKey (KeyCode.Escape))
		{
			Time.timeScale = 0; //O tempo irá congelar.
			//E todos os buttons estarão ativados.
			replayPause.SetActive (true);
			proximoPause.SetActive (false); //Menos o da próxima scene,que será subistuido pelo de carregar outra scene falso ou seja sem função pra não carregar próxima cena.
			menuPause.SetActive (true);
			descongelarBtn.SetActive (true);
			proximoFalse.SetActive (true);
		}
			

	}

	//Função pra desativar esses todos buttons abaixo,quando clicar um certo button,nesse caso o button de tirar pause.
	public void descongelarTemppo()
	{
		Time.timeScale = 1;
		replayPause.SetActive (false);
		proximoPause.SetActive (false);
		menuPause.SetActive (false);
		descongelarBtn.SetActive (false);
		proximoFalse.SetActive (false);

	}
}
