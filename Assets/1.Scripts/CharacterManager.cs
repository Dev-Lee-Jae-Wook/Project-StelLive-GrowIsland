using System;
using UnityEngine;
using Sirenix;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Collections;

namespace StelLiveGrowIsland
{
	public class CharacterManager : SerializedMonoBehaviour
	{
		#region Inspector Field
		[SerializeField] private GameManager _gameManager;
		#endregion

		#region Fild
		private Dictionary<StelLiveCharacterType, CharacterBase> _characterTable = new();
		#endregion

		#region Properties
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		private void Awake()
		{
			CharacterBase[] characters = GetComponentsInChildren<CharacterBase>();
			foreach (var character in characters)
			{
				character.Initilize();
				_characterTable.Add(character.characterType, character);
			}
		}
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods

		#endregion

		#region Coroutines
		private IEnumerator CharacterAction(StelLiveCharacterType type)
		{
			yield return _characterTable[type].Action();

			_gameManager.TrunEnd();
		}
		#endregion

		#region Debug Methods
		#endregion
		public void SpawnCharacter(StelLiveCharacterType type)
		{
			_characterTable[type].Spawn();
			StartCoroutine(CharacterAction(type));
		}
	}
}
