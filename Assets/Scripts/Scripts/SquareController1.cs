using UnityEngine;

public class SquareController1 : MonoBehaviour
{
    public int a;
    public int number;
    private void Awake()
    {
        Debug.LogWarning("kaidoujin");
        var gacha = a;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("jinkaidou");
    }

    // Update is called once per frame
    void Update()
    {
      
        Transport(a);
    }

    void Transport(int i)
    {
        this.gameObject.transform.Rotate(0, 0, 1);
        if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(number, 0, 0);
            Debug.LogError(this.gameObject.transform.position.x + " toa do x ");
            Debug.LogWarning(this.gameObject.transform.position.y + " toa do y ");
        }
        else if (this.gameObject.transform.position.x >= number && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(0, number, 0);
            Debug.Log(this.gameObject.transform.position.y);
        }
        else if (this.gameObject.transform.position.x >= number && this.gameObject.transform.position.y >= number)
        {
            this.gameObject.transform.position += new Vector3(-number, 0, 0);
            Debug.LogError(this.gameObject.transform.position.x);
        }
        else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y >= number)
        {
            this.gameObject.transform.position += new Vector3(0, -number, 0);
            Debug.Log(this.gameObject.transform.position.y);
        }
    }

    void game()
    {
        
    }
}
