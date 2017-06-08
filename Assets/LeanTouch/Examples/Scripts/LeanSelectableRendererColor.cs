using UnityEngine;


namespace Lean.Touch
{
    
	// This script allows you to change the color of the SpriteRenderer attached to the current GameObject
	[RequireComponent(typeof(Renderer))]
	public class LeanSelectableRendererColor : LeanSelectableBehaviour
	{
		[Tooltip("Automatically read the DefaultColor from the Renderer.material?")]
		public bool AutoGetDefaultColor;

		[Tooltip("The default color given to the Renderer.material")]
		public Color DefaultColor = Color.white;

		[Tooltip("The color given to the Renderer.material when selected")]
		public Color SelectedColor = Color.green;

        int flag = 0;

        protected virtual void Awake()
		{
			if (AutoGetDefaultColor == true)
			{
				var renderer = GetComponent<Renderer>();

				DefaultColor = renderer.sharedMaterial.color;

            }
		}
		
		protected override void OnSelect(LeanFinger finger)
		{
            //선택된 것 처리 *2배
            if (flag == 1)
            {
                transform.localScale /= 2f;          
                flag = 0;
            }
            else
            {
                transform.localScale *= 2f;
                flag = 1;
            }
        }

		protected override void OnDeselect()
		{
            //선택되지 않은 나머지의 처리
        }

		private void ChangeColor(Color color)
		{
			var renderer = GetComponent<Renderer>();

			// Clone material and change color
			renderer.material.color = color;
		}
	}
}