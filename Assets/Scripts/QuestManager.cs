using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour {

	
	private static QuestManager m_instance;
	
	public static QuestManager Instance	{
		get{
			return m_instance;
		}
	}

	void Awake () {
		m_instance = this;
		if(PlayerPrefs.GetInt("index") != null)
			index = PlayerPrefs.GetInt("index");
	}


	public void CompleteTip(int i){

		Debug.Log(i + "    index: " + index); 
		if(i== index+1){
			index++;
			PlayerPrefs.SetInt("index", index);
		}
		else if(i <= index)
			index = i;
		else
			error = true;
	}


	void TipError(){

		GUILayout.TextArea("Gaaarrr, voce pulou as pistas anterirores. " +
			"Volte e ache as outras pistas e depois retorne aqui" +
		                   "quando for a vez!");
		if(GUILayout.Button("Continuar")){
			error = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}

	public bool error = false;
	public string[] questTips;
	public int index = 0;
	void QuestTipBox(){

		GUILayout.TextArea(questTips[index]);


	}
	public GUISkin skin;
	void OnGUI(){
		GUI.skin = skin;
		if(enabled){
			if(error == true)
				TipError();
			else
				QuestTipBox();
		}
	}
}
