using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public enum StelLiveCharacterType
    {
        None,
		GangZi,
		Yuni,
		Hina,
		Mashiro,
		Lize,
		Tabi,
		Shibuki,
		Rin,
		Nana,
		Riko
	}


    public class ChoiceButtonManager : SerializedMonoBehaviour
	{
		#region Inspector Field
		public Dictionary<StelLiveCharacterType, Sprite> _iconTable = new();
		[SerializeField] private GraphicRaycaster _graphicRaycaster;
		[SerializeField] private GameManager _gameManger;
		#endregion

		#region Fild
		private ChoiceButton[] choiceButtons;
		#endregion

		#region Properties
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		private void Awake()
		{
			if (choiceButtons == null)
			{
				Initialize();
			}
		}

		private void OnDestroy()
		{
			_gameManger.OnTrunStart -= InteractionOn;
		}
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		[Button("Initialize")]
		private void Initialize()
		{
			choiceButtons = transform.GetComponentsInChildren<ChoiceButton>();
			foreach (var button in choiceButtons)
			{
				button.Initialize(_iconTable[button.Type]);
				button.OnChoiced += Choiced;
			}

			SetChoiceInteraction(false);
			_gameManger.OnTrunStart += InteractionOn;

		}
		private void Choiced(StelLiveCharacterType type)
		{
			Debug.Log($"{type} Choice");
			InteractionOff();
			_gameManger.TrunEnd();
		}

		/// <summary>
		/// 선택 UI의 상호작용을 설정합니다.
		/// </summary>
		private void SetChoiceInteraction(bool isInteraction)
		{
			_graphicRaycaster.enabled  = isInteraction;
		}

		private void InteractionOn()
		{
			SetChoiceInteraction(true);
		}

		private void InteractionOff()
		{
			SetChoiceInteraction(false);
		}
		#endregion

		#region Coroutines
		#endregion
	}
}
