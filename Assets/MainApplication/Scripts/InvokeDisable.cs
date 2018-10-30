using UnityEngine;

public class InvokeDisable : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		Invoke("DisableAfterStart", 1.5f);
	}

	void DisableAfterStart()
	{
		gameObject.SetActive(false);
	}
}
