using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MealPlan
    {
        private Dictionary<DateTime, Recipe> plan = new Dictionary<DateTime, Recipe>();
        private ListView listView;
        public MealPlan(ListView listView)
        {
            this.listView = listView;
            LoadPlan();
        }
        private void LoadPlan()
        {
            listView.Items.Clear();
            foreach (var entry in plan)
            {
                listView.Items.Add(new ListViewItem(new[] { entry.Key.ToString("dd.MM.yyyy"),
                entry.Value.Name }));
            }
        }
        public void AddRecipeToPlan()
        {
            /*var newRecipe = new Recipe();
            newRecipe.ShowDialog();
            if (addRecipeForm.DialogResult == DialogResult.OK)
            {
                var recipe = new Recipe(
                newRecipe.Name,
                newRecipe.Description,
                newRecipe.Ingredients,
                newRecipe.Instructions,
                newRecipe.Calories);
                if (plan.ContainsKey(newRecipe.Date))
                {
                    MessageBox.Show("На эту дату рецепт уже добавлен.");
                }
                else
                {
                    plan.Add(newRecipe.Date, recipe);
                    LoadPlan();
                    MessageBox.Show("Рецепт добавлен в план.");
                }
            }*/
        }
        public void RemoveRecipeFromPlan()
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выберите рецепт для удаления.");
                return;
            }
            var date = DateTime.Parse(listView.SelectedItems[0].SubItems[0].Text);
            if (plan.ContainsKey(date))
            {
                plan.Remove(date);
                LoadPlan();
                MessageBox.Show("Рецепт удалён.");
            }
            else
            {
                MessageBox.Show("Рецепт не найден.");
            }
        }
        public void SearchRecipeByName()
        {
            /*var searchForm = new SearchRecipeForm();
            searchForm.ShowDialog();
            if (searchForm.DialogResult == DialogResult.OK)
            {
                var foundRecipe = plan.Values.FirstOrDefault(r =>
                r.Name.Contains(searchForm.Name, StringComparison.OrdinalIgnoreCase));
                if (foundRecipe != null)
                {
                    var recipeForm = new RecipeForm();
                    recipeForm.Recipe = foundRecipe;
                    recipeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Рецепт не найден.");
                }
            }*/
        }
    }

}
