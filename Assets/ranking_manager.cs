using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ranking_manager : MonoBehaviour
{
    public static List<rank> ranks = new List<rank>();
    public GameObject panelPrefab, scrollContent;
    // Start is called before the first frame update
    void Start()
    {
        ranks = ranks.OrderByDescending(e => e.score).ToList();
        for (int i = 0; i < ranks.Count; i++)
        {
            GameObject rankPanel = Instantiate(panelPrefab);
            rankPanel.transform.SetParent(scrollContent.transform);
            rankPanel.GetComponent<RectTransform>().anchoredPosition = new Vector3(0,-15+(i*-30));
            SetChildText(rankPanel, 0,(i+1).ToString());
            SetChildText(rankPanel, 1,ranks[i].snumber.ToString());
            SetChildText(rankPanel, 2, ranks[i].name.ToString());
            SetChildText(rankPanel, 3, ranks[i].score.ToString());

        }
        scrollContent.GetComponent<RectTransform>().sizeDelta = new Vector2(1, ranks.Count * 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetChildText(GameObject rankPanel,int number, string text)
    {
        rankPanel.transform.GetChild(number).GetComponent<TMPro.TextMeshProUGUI>().text = text;
        rankPanel.transform.localScale=new Vector3(1,1,1);
    }
}
public class rank
{
    public string snumber;
    public string name;
    public int score;

}

