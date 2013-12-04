using UnityEngine;
using System.Collections;

public class QuestComplete : MonoBehaviour {

	public int quest_Tip;

	void OnBecameVisible() {
		QuestManager.Instance.CompleteTip(quest_Tip);

	}
	void OnBecameInvisible() {

	}
}
