using System;
using UnityEngine;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public class ChoiceButton : MonoBehaviour
	{
		public StelLiveCharacterType Type => ChoiceButtonType;

		[SerializeField] private StelLiveCharacterType ChoiceButtonType;

		[SerializeField] private Button _button;
		[SerializeField] private Image _image;

		public event Action<StelLiveCharacterType> OnChoiced;

		private void OnValidate()
		{
			gameObject.name = $"{Type} Button";
		}


		public void Initialize(Sprite buttonImage)
		{
			_button.interactable = true;
			_image.sprite = buttonImage;
			_button.onClick.AddListener(Choice);
		}

		private void Choice()
		{
			OnChoiced?.Invoke(Type);
			_button.interactable = false;
		}
	}
}
