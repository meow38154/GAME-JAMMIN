//using UnityEditor;
//using UnityEngine;
//using static UnityEngine.GraphicsBuffer;

//[CustomEditor(typeof(ObjectMove))]
//public class ObjectMoveEditor : UnityEditor.Editor
//{
//    private SerializedProperty _moveType;

//    private SerializedProperty _moveVector;
//    private SerializedProperty _translate;

//    private SerializedProperty _target;
//    private SerializedProperty _lerp;
//    private SerializedProperty _speed;

//    private void OnEnable()
//    {
//        _moveType = serializedObject.FindProperty("_moveType");

//        _moveVector = serializedObject.FindProperty("_moveVector");

//        _translate = serializedObject.FindProperty("_translate");

//        _target = serializedObject.FindProperty("_target");

//        _lerp = serializedObject.FindProperty("_lerp");

//        _speed = serializedObject.FindProperty("_basu");
//    }

//    public override void OnInspectorGUI()
//    {
//        serializedObject.Update();

//        EditorGUILayout.PropertyField(_moveType);

//        var outlineInfo = target as ObjectMove;

//        if (outlineInfo != null)
//        {

//            if (outlineInfo.MovementType == MoveType.Basic)
//            {
//                EditorGUILayout.PropertyField(_moveVector);
//                EditorGUILayout.PropertyField(_translate);
//            }
//            else if (outlineInfo.MovementType == MoveType.Follow)
//            {
//                EditorGUILayout.PropertyField(_target);
//                EditorGUILayout.PropertyField(_lerp);
//                EditorGUILayout.PropertyField(_speed);
//            }
//        }

//        serializedObject.ApplyModifiedProperties();
//    }
//}
