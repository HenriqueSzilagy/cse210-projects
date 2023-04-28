public class PromptGenerator {
    public List<string> _questions;

    public PromptGenerator() {
        
        _questions = new List<string>() {
        "What can I do differently tomorrow so I can be a little better?",
        "What did I learn today?",
        "What did I do today that made me happy?",
        "What am I grateful for today?",
        "Which passage from the Scriptures that I read today did I like?",
        "What did I miss the most today?",
        "How could I bless someone's life today?"
        };
    }
    public string ChoosePrompt() {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
}
