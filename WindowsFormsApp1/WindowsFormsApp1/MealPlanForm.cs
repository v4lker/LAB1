using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MealPlanForm : Form
    {
        private MealPlan mealPlan;
        private ListView listView;
        private Button addRecipeButton;
        private Button removeRecipeButton;
        private Button searchRecipeButton;
        public MealPlanForm()
        {
            this.Text = "Планирование меню";
            this.Width = 407;
            this.Height = 370;
            CreateControls();
            mealPlan = new MealPlan(listView);
        }
        private void CreateControls()
        {
            listView = new ListView
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(380, 280),
                View = View.Details,
                FullRowSelect = true
            };
            listView.Columns.Add("Дата", 100);
            listView.Columns.Add("Название", 270);
            addRecipeButton = new Button
            {
                Location = new System.Drawing.Point(10, 300),
                Text = "Добавить рецепт",
                Size = new System.Drawing.Size(100, 25)
            };
            addRecipeButton.Click += (sender, e) => mealPlan.AddRecipeToPlan();
            removeRecipeButton = new Button
            {
                Location = new System.Drawing.Point(120, 300),
                Text = "Удалить рецепт",
                Size = new System.Drawing.Size(100, 25)
            };
            removeRecipeButton.Click += (sender, e) => mealPlan.RemoveRecipeFromPlan();
            searchRecipeButton = new Button
            {
                Location = new System.Drawing.Point(230, 300),
                Text = "Поиск рецепта",
                Size = new System.Drawing.Size(100, 25)
            };
            searchRecipeButton.Click += (sender, e) => mealPlan.SearchRecipeByName();
            this.Controls.Add(listView);
            this.Controls.Add(addRecipeButton);
            this.Controls.Add(removeRecipeButton);
            this.Controls.Add(searchRecipeButton);
        }
    }

}
