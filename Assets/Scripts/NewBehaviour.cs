using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviour : MonoBehaviour
{
    public Text Conversation_txt;
    public Image Conversation_char;
    public Text Conversation_name;
    public string[] charName = new string[7];
    public Sprite[] charImages = new Sprite[7];
    void Start()
    {

    }

    void Update()
    {

    }
    public void Enter1()
    {
        string[] conversation = { "學習這些東西小意思啦！我可以的！", "這個學習關卡看起來很有趣，我期待能學到新知識！", "或許這個關卡對我來說太困難了吧，但我試試看。", "為什麼我要浪費時間在這個破關卡上？！", "這個學習關卡應該能夠迎合我的才華吧？", "我好緊張，但我相信我可以克服困難！", "這個學習關卡似乎是我需要的，讓我專心學習吧。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter2()
    {
        string[] conversation = { "學習這些東西小意思啦！我可以的！", "這個學習關卡看起來很有趣，我期待能學到新知識！", "或許這個關卡對我來說太困難了吧，但我試試看。", "為什麼我要浪費時間在這個破關卡上？！", "這個學習關卡應該能夠迎合我的才華吧？", "我好緊張，但我相信我可以克服困難！", "這個學習關卡似乎是我需要的，讓我專心學習吧。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter3()
    {
        string[] conversation = { "準備接受第一次的挑戰了！", "我相信學習的道路充滿了美好，讓我開始我的冒險吧！", "這是我第一次嘗試答題關卡，希望我能夠有所進步", "我真是受夠了！這種簡單的問題還需要我來浪費時間解答！", "這種輕而易舉的問題算什麼？讓我來簡單搞定！", "我緊張但我會嘗試的！這是我第一次挑戰答題關卡!", "這是一個新的開始，我迫不及待想要開始學習新的知識！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter4()
    {
        string[] conversation= { "這學習關卡看起來很刺激！我迫不及待要開始挑戰了！", "我期待著這個學習關卡能帶給我美好的學習體驗。", "別懷疑我的能力！這個關卡對我來說只是小菜一碟！", "這關卡為什麼這麼難？這簡直就是在考驗我的耐心！", "我知道這個關卡可能會很困難，但我會盡力而為。", "我好緊張，但我相信我能做到！我會盡力的！", "這個學習關卡的內容真是令人激動！我迫不及待要開始學習！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter5()
    {
        string[] conversation= { "這學習關卡看起來很刺激！我迫不及待要開始挑戰了！", "我期待著這個學習關卡能帶給我美好的學習體驗。", "別懷疑我的能力！這個關卡對我來說只是小菜一碟！", "這關卡為什麼這麼難？這簡直就是在考驗我的耐心！", "我知道這個關卡可能會很困難，但我會盡力而為。", "我好緊張，但我相信我能做到！我會盡力的！", "這個學習關卡的內容真是令人激動！我迫不及待要開始學習！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter6()
    {
        string[] conversation= { "這個關卡比上一關更有挑戰性，但我相信我能克服！", "每一關都是一次成長的機會，我願意接受並學習。", "每關的難度都在增加，我只能試試看，也許會有驚喜。", "別想輕易擊敗我！我會用我的怒火將這個關卡燒成灰燼！", "這個關卡的挑戰對我來說還算不錯，不過我需要更多刺激！", "上一關的經驗讓我更有信心，我會更加努力完成這個關卡！", "我喜歡挑戰，這個關卡對我來說是提升自己的機會！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter7()
    {
        string[] conversation= { "給我一些有挑戰性的問題，讓我展現我的智慧！", "學習是一種成長，我希望這個關卡能讓我更加豐富內心。", "或許這個關卡能讓我忘記一下現實生活中的困難，我會試試看。", "別讓我在這個關卡上浪費太多時間，否則我會發飆的！", "既然是我挑戰這個關卡，肯定有什麼特別的獎勵在等著我！", "我需要一點鼓勵和支持，請大家陪我一起完成這個關卡。", "讓我靜下心來，專注地學習吧。這個關卡對我來說是一個很好的挑戰。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter8()
    {
        string[] conversation= { "給我一些有挑戰性的問題，讓我展現我的智慧！", "學習是一種成長，我希望這個關卡能讓我更加豐富內心。", "或許這個關卡能讓我忘記一下現實生活中的困難，我會試試看。", "別讓我在這個關卡上浪費太多時間，否則我會發飆的！", "既然是我挑戰這個關卡，肯定有什麼特別的獎勵在等著我！", "我需要一點鼓勵和支持，請大家陪我一起完成這個關卡。", "讓我靜下心來，專注地學習吧。這個關卡對我來說是一個很好的挑戰。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter9()
    {
        string[] conversation= { "學習越深入，難度也隨之增加，這就是成長的過程！", "學習不僅僅是答對問題，也是培養思考和解決問題的能力。", "這個關卡看起來很難，但我會盡力解決問題，不管結果如何。", "這些問題真是氣死人！不過，我還是要堅持下去！", "這些問題很有趣，但還不夠嚴峻，讓我看看有沒有更高難度的！", "每次進步一點點，我會努力克服自己的不安感，繼續前進!", "每個關卡都讓我更深入地理解學習的重要性，我會持續努力！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter10()
    {
        string[] conversation= { "學習這些東西小意思啦！我可以輕鬆搞定！", "學習關卡是我展現溫柔和耐心的好機會，我會用心面對。", "我已經預見到了這次學習關卡的失敗，但我還是會嘗試。", "這次學習關卡讓我更生氣了！但我也要看看到底有多糟糕！", "這個學習關卡能有多難呢？反正我一定能搞定！", "我好緊張啊，希望我能順利完成學習關卡！", "學習關卡是我展現知識的舞台，我要讓大家看到我的努力。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter11()
    {
        string[] conversation= { "學習這些東西小意思啦！我可以輕鬆搞定！", "學習關卡是我展現溫柔和耐心的好機會，我會用心面對。", "我已經預見到了這次學習關卡的失敗，但我還是會嘗試。", "這次學習關卡讓我更生氣了！但我也要看看到底有多糟糕！", "這個學習關卡能有多難呢？反正我一定能搞定！", "我好緊張啊，希望我能順利完成學習關卡！", "學習關卡是我展現知識的舞台，我要讓大家看到我的努力。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter12()
    {
        string[] conversation= { "即使我戴著眼鏡，但這個關卡中的問題對我來說也不是問題！", "我相信每個人都有自己獨特的學習方式，我要找到適合我的方法！", "即使我處在輪椅上，我也不會被這個關卡打敗！", "再多的問題也改變不了我易怒的本性！但我還是要把它們解決掉！", "別小看我的傲嬌，即使是這麼複雜的問題，我也能輕鬆應對！", "坐在這裡或許有些不方便，但我不會讓這影響我的學習進程！", "即使是在讀書的過程中，我也能感受到成長的喜悅，這太棒了！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter13()
    {
        string[] conversation= { "這次學習關卡看起來有趣，我迫不及待地想開始了！", "我希望這次學習關卡能讓我更加融入知識的世界，感受到學習的美好。", "或許我在這次學習關卡能找到一點點的希望，但我不抱太大期望。", "我現在心情不好，但這不代表我不會嘗試這個學習關卡，希望有些驚喜等著我。", "唉，不管怎樣，我也只能進去試試看，希望不會太無聊！", "儘管緊張，但我知道這是我成長的機會，我會盡力克服困難！", "學習關卡對我來說是一個考驗，但我會靜下心來克服每一道難題。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter14()
    {
        string[] conversation= { "這次學習關卡看起來有趣，我迫不及待地想開始了！", "我希望這次學習關卡能讓我更加融入知識的世界，感受到學習的美好。", "或許我在這次學習關卡能找到一點點的希望，但我不抱太大期望。", "我現在心情不好，但這不代表我不會嘗試這個學習關卡，希望有些驚喜等著我。", "唉，不管怎樣，我也只能進去試試看，希望不會太無聊！", "儘管緊張，但我知道這是我成長的機會，我會盡力克服困難！", "學習關卡對我來說是一個考驗，但我會靜下心來克服每一道難題。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter15()
    {
        string[] conversation= { "這是最後一關了，我已經準備好迎接最大的挑戰！", "完成最後一關，我感到充滿喜悅！學習的旅程還有更多等著我。", "我完成了最後一關！儘管困難重重，但我終於做到了！", "終於熬過了最後一關！現在我可以松口氣了！", "這是最後一關了？我還以為會有更多挑戰！不過，我當然是輕鬆完成了。", "經過一番努力，我成功地挑戰完最後一關了！我感到非常自豪！", "最後一關了！我已經迎接了學習的全部挑戰，並取得了成功！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter16()
    {
        string[] conversation= { "這是一個很好的複習機會，我會將知識牢牢記在腦海中！", "這是一個很好的機會再次回顧前幾關的內容，我會用心回答每一個問題。", "這個複習關卡能讓我再次回顧之前的學習，或許我能發現自己的進步。", "這些問題也許能平息我憤怒的心情，我要證明我可以控制自己！", "這個複習關卡可能無法滿足我的期望，但我還是要展現出最好的水平！", "這是一個很好的機會回顧前幾關的內容，我會盡力回答問題！", "這是一個很好的複習機會，我會全力回答這些問題並加深對知識的理解。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter17()
    {
        string[] conversation= { "這是一個很好的複習機會，我會將知識牢牢記在腦海中！", "這是一個很好的機會再次回顧前幾關的內容，我會用心回答每一個問題。", "這個複習關卡能讓我再次回顧之前的學習，或許我能發現自己的進步。", "這些問題也許能平息我憤怒的心情，我要證明我可以控制自己！", "這個複習關卡可能無法滿足我的期望，但我還是要展現出最好的水平！", "這是一個很好的機會回顧前幾關的內容，我會盡力回答問題！", "這是一個很好的複習機會，我會全力回答這些問題並加深對知識的理解。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter18()
    {
        string[] conversation= { "這是一個很好的複習機會，我會將知識牢牢記在腦海中！", "這是一個很好的機會再次回顧前幾關的內容，我會用心回答每一個問題。", "這個複習關卡能讓我再次回顧之前的學習，或許我能發現自己的進步。", "這些問題也許能平息我憤怒的心情，我要證明我可以控制自己！", "這個複習關卡可能無法滿足我的期望，但我還是要展現出最好的水平！", "這是一個很好的機會回顧前幾關的內容，我會盡力回答問題！", "這是一個很好的複習機會，我會全力回答這些問題並加深對知識的理解。" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter19()
    {
        string[] conversation= { "這些問題涉及到了更多的知識範疇，我要全力應對！", "這些問題稍微有些挑戰，但我相信我可以通過溫柔和耐心來克服困難！", "儘管這些問題有些挑戰性，但我不會輕易放棄，我會盡力完成它們！", "這個複習關卡對我來說可能是一個考驗，但我絕不會讓它們擊敗我！", "我已經熟悉了前幾關的內容，這個複習關卡對我來說只是小菜一碟！", "我對之前的知識有了更深刻的理解，現在我要更有信心地挑戰這些問題！", "我已經建立了一個穩固的知識基礎，現在我要運用它們來解決更複雜的問題！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter20()
    {
        string[] conversation= { "這些問題涉及到了更多的知識範疇，我要全力應對！", "這些問題稍微有些挑戰，但我相信我可以通過溫柔和耐心來克服困難！", "儘管這些問題有些挑戰性，但我不會輕易放棄，我會盡力完成它們！", "這個複習關卡對我來說可能是一個考驗，但我絕不會讓它們擊敗我！", "我已經熟悉了前幾關的內容，這個複習關卡對我來說只是小菜一碟！", "我對之前的知識有了更深刻的理解，現在我要更有信心地挑戰這些問題！", "我已經建立了一個穩固的知識基礎，現在我要運用它們來解決更複雜的問題！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
    public void Enter21()
    {
        string[] conversation= { "這是我展現所有學到的知識的時候，我已經準備好了！", "我希望我的溫柔和堅持能夠幫助我順利完成最後一關，我相信我可以做到！", "這是我證明自己的機會，儘管我在輪椅上，我也能超越自己的極限！", "最後一關了，這是我掌握自己情緒的機會，我要用冷靜的心態完成它！", "這是我展現真正實力的時刻，我將讓所有人見識到我的優越性！", "我經歷了一段成長的旅程，現在是時候展現出我的實力了！", "這是我展現我讀書成果的時刻，我已經為這一刻做好了準備！" };
        Conversation_name.text = charName[GameManager.charN];
        Conversation_txt.text = conversation[GameManager.charN];
        Conversation_char.sprite = charImages[GameManager.charN];
    }
}
