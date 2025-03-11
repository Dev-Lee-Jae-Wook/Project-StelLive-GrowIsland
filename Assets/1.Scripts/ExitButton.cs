using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
	[SerializeField] private Button _exit;
	private void Start()
	{
		_exit.onClick.AddListener(Exit);
	}

	private void Exit()
	{
		Application.Quit();
	}
}
