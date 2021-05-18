using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace App
{
    public class TodoList {

        private List<ICompletable> completables = new List<ICompletable>();

        public void add(ICompletable completable) {
            completables.Add(completable);
        }

        public List<ICompletable> all() {
            return completables;
        }

        public List<ICompletable> completed() =>
            completables.Where(c => c.isComplete).ToList();

        public List<ICompletable> uncompleted() => 
            completables.Where(c => !c.isComplete).ToList();

        public void completeAll() =>
            completables.ForEach(c => c.markComplete());

        public void uncompleteAll() =>
            completables.ForEach(c => c.markIncomplete());

        public override string ToString() {
            StringBuilder builder = new StringBuilder();

            completables.ForEach(completable => {
                if (completable.isComplete) {
                    builder.Append("√ ");
                } else {
                    builder.Append("□ ");
                }

                builder.Append(completable.TextToDisplay).Append("\n");
            });

            return builder.ToString();
        }
    }
}
