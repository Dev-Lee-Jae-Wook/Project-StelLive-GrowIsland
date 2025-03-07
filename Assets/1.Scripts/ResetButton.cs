using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public class ResetButton : MonoBehaviour
	{
		#region Inspector Field
		#endregion

		#region Fild
		private Button _resetButton;
		#endregion

		#region Properties
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		private void Awake()
		{
			_resetButton = GetComponent<Button>();
			_resetButton.onClick.AddListener(GameReset);
		}
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		private void GameReset()
		{
			SceneManager.LoadScene(0);
		}
		#endregion

		#region Coroutines
		#endregion

		#region Debug Methods
		#endregion
	}
}
