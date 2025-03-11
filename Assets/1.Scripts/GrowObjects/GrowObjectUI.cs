using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public class GrowObjectUI : MonoBehaviour
	{
		#region Inspector Field
		[SerializeField] private TMP_Text _text;
		#endregion

		#region Fild
		private GrowObjectBase _growObject;
		#endregion

		#region Properties
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		private void Start()
		{
			_growObject = GetComponent<GrowObjectBase>();
		}
		private void Update()
		{
			_text.text = $"{_growObject.ObjectType} LV : {_growObject.Lv}";
		}
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		#endregion

		#region Protectd Mehtods
		#endregion

		#region Coroutines
		#endregion

		#region Debug Methods
		#endregion
	}
}
