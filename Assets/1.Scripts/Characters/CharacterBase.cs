using System;
using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public abstract class CharacterBase : MonoBehaviour
	{
		#region Inspector Field
		[SerializeField] private Transform _spawnPoint;
		#endregion

		#region Fild
		#endregion

		#region Properties
		public abstract StelLiveCharacterType characterType { get; }
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		#endregion

		#region Public Methods
		public void Initilize()
		{
			gameObject.SetActive(false);
		}
		public void Spawn()
		{
			Debug.Log($"{characterType}이 소환되었습니다.");
			transform.position = _spawnPoint.position;
			gameObject.SetActive(true);
		}
		#endregion

		#region Private Methods
		#endregion

		#region Coroutines
		public abstract IEnumerator Action();
		#endregion

		#region Debug Methods
		#endregion
	}
}
