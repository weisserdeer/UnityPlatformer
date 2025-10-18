using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed; //unity will save the value of this field into the scene

    private float _xdirection;
    private float _ydirection;

    public void SetXDirection(float xdirection)
    {
        _xdirection = xdirection;
    }
    public void SetYDirection(float ydirection)
    {
        _ydirection = ydirection;
    }

    private void Update()
    {
        
        if (_xdirection != 0)
        {
            var delta = _xdirection * _speed * Time.deltaTime; //deltaTime - the time since the last frame
            var newXPosition = transform.position.x + delta;
            transform.position = new Vector2(newXPosition, transform.position.y);
        }

        if (_ydirection != 0)
        {
            var delta = _ydirection * _speed * Time.deltaTime; //deltaTime - the time since the last frame
            var newYPosition = transform.position.y + delta;
            transform.position = new Vector2(transform.position.x, newYPosition);
        }

    }

    public void SaySomething()
    {
        Debug.Log("Something");
    }
}
