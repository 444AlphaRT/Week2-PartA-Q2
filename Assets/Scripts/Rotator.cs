using UnityEngine;

public class Turning : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    // משתנה פרטי שניתן לשנות מה-Inspector ביוניטי.  
    // מגדיר את מהירות הסיבוב של האובייקט (במעלות לשנייה).

    // Start מופעלת פעם אחת כשהאובייקט נטען לסצנה לפני הפעלת Update.
    void Start()
    {
        Debug.Log("starting :-)");
        // מדפיס הודעה לוודא שהסקריפט התחיל לפעול.

        GetComponent<Transform>().position = new Vector3(0, 0, 0);
        // מאפס את מיקום האובייקט לנקודת הראשית (0,0,0) במרחב.
        // GetComponent<Transform>() ניגש לרכיב ה-Transform של האובייקט כדי לשנות את המיקום שלו.
    }

.
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
        // מסובבת את האובייקט סביב ציר ה-Z.  
        // Time.deltaTime שומר על סיבוב אחיד בזמן אמיתי (לא תלוי בכמות הפריימים לשנייה).  
    }
}

