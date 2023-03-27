using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DynamicScreen : MonoBehaviour
{
    private SpriteRenderer _gameBackground;
    private Camera sceneCamera;
    private float screenRatio, targetRatio, differenceInHeight;

    private void Awake()
    {
        _gameBackground = GetComponent<SpriteRenderer>();

        sceneCamera = Camera.main;

        screenRatio = (float)Screen.width / (float)Screen.height;
        targetRatio = _gameBackground.bounds.size.x / _gameBackground.bounds.size.y;

        differenceInHeight = targetRatio / screenRatio;

        if(screenRatio >= targetRatio)
        {
            sceneCamera.orthographicSize = _gameBackground.bounds.size.y / 2;
        }
        else
        {
            sceneCamera.orthographicSize = _gameBackground.bounds.size.y / 2 * differenceInHeight;
        }
    }
}