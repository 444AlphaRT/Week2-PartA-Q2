using UnityEngine;  

public class turning : MonoBehaviour  
{
    [SerializeField] private float speed = 100f;
    // שתהיה אפשרות לשנות מהיוניטי כשהשדה בפרייבט
    // הוא קובע את מהירות הסיבוב של האובייקט — ברירת המחדל היא 100 מעלות לשנייה.

    void Start()
    {
        Debug.Log("starting :-)");
        // מדפיסה הודעה לקונסול כדי לוודא שהסקריפט התחיל לפעול.

        GetComponent<Transform>().position = new Vector3(0,0,0); // מעדכנת את האובייקט למרכז המסך
    }

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
        // מסובבת את האובייקט סביב ציר ה-Z.
        // Time.deltaTime מוודא שהתנועה תהיה אחידה בכל מחשב, ללא תלות בקצב הפריימים.
    }
}
