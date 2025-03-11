using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public class GrowObjectManager : MonoBehaviour
	{
		#region Inspector Field
		#endregion

		#region Fild
		[SerializeField] private Dictionary<GrowObjectType, GrowObjectBase> _growObjectTable = new();
		#endregion

		#region Properties
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		private void Awake()
		{
			GrowObjectBase[] growObjects = GetComponentsInChildren<GrowObjectBase>();
			foreach (GrowObjectBase growObject in growObjects)
			{
				growObject.Initilize(this);
				_growObjectTable.Add(growObject.ObjectType, growObject);
			}
		}
		#endregion

		#region Public Methods
		public GrowObjectBase GetGrowObject(GrowObjectType type)
		{
			return _growObjectTable[type];
		}
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
