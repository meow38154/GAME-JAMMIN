using UnityEngine;

namespace Irw_Button
{
    [CreateAssetMenu(fileName = "ButtonSettingSO", menuName = "IrwSO/ButtonSettingSO")]
    public class ButtonSettingSO : ScriptableObject
    {
        [field:SerializeField] public Sprite nomalSprite { get; private set; }
        [field: SerializeField] public Sprite dawnSprite { get; private set; }
        [field: SerializeField] public float buttonDawnSpeed { get; private set; } = 20;
        [field: SerializeField] public float buttonUPSpeed { get; private set; } = 20;
    }
}

