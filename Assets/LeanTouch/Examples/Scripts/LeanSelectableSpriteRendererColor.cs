using UnityEngine;


namespace Lean.Touch
{
	// This script allows you to change the color of the SpriteRenderer attached to the current GameObject
	[RequireComponent(typeof(SpriteRenderer))]
	public class LeanSelectableSpriteRendererColor : LeanSelectableBehaviour
	{
		[Tooltip("Automatically read the DefaultColor from the SpriteRenderer?")]
		public bool AutoGetDefaultColor;

		[Tooltip("The default color given to the SpriteRenderer")]
		public Color DefaultColor = Color.white;

		[Tooltip("The color given to the SpriteRenderer when selected")]
		public Color SelectedColor = Color.green;

        int flag = 0;

        protected virtual void Awake()
		{
			if (AutoGetDefaultColor == true)
			{
				var spriteRenderer = GetComponent<SpriteRenderer>();

				DefaultColor = spriteRenderer.color;
			}
		}

		protected override void OnSelect(LeanFinger finger)
		{
            if (flag == 1) {
                transform.localScale /= 3.0f;
                flag = 0;
            }
            else
            {
                transform.localScale *= 3.0f;
                flag = 1;
            }

        }

		protected override void OnDeselect()
		{
		}

		private void ChangeColor(Color color)
		{
			var spriteRenderer = GetComponent<SpriteRenderer>();

			spriteRenderer.color = color;
		}
	}
}