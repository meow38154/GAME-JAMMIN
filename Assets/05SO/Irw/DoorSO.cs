using UnityEngine;

namespace Irw_SO
{
    [CreateAssetMenu(fileName = "DoorSO", menuName = "IrwSO/DoorSO")]
    public class DoorSO : ScriptableObject
    {
        [field: SerializeField] public Sprite CloseSprite { get; private set; }
        [field:SerializeField] public Sprite OpenSprite { get; private set; }
    }
}

