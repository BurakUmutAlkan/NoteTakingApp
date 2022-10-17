using NoteTakingApp.Data;
using NoteTakingApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class MainForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public MainForm()
        {
            InitializeComponent();
            GetAllNotes();
            HideUnusedFeatures();
        }

        private void HideUnusedFeatures()
        {
            gbCategory.Hide();
        }

        private void FilterNotes()
        {
            lstNotesList.DataSource = new List<string>();
            List<Note> noteList = db.Notes.OrderByDescending(note => note.CreationTime).ToList();

            string title = txtFilterTitle.Text.Trim();

            if (title == "")
                lstNotesList.DataSource = noteList.Select(note => note.Title).ToList();
            else if (title != "")
                lstNotesList.DataSource = noteList.Where(note => note.Title == title).Select(note => note.Title).ToList();

            //bool work = cbWork.Checked;
            //bool school = cbSchool.Checked;
            //bool personal = cbPersonal.Checked;

            //if (title == "" && !work && !school && !personal) // (0, 0, 0, 0)
            //    lstNotesList.DataSource = noteList.Select(note => note.Title).ToList();
            //else if (title != "" && !work && !school && !personal) // (1, 0, 0, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Title == title).Select(note => note.Title).ToList();
            //else if (title == "" && work && !school && !personal) // (0, 1, 0, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Work").Select(note => note.Title).ToList();
            //else if (title == "" && !work && school && !personal) // (0, 0, 1, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "School").Select(note => note.Title).ToList();
            //else if (title == "" && !work && !school && personal) // (0, 0, 0, 1)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Personal").Select(note => note.Title).ToList();
            //else if (title != "" && work && !school && !personal) // (1, 1, 0, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Work" && note.Title == title).Select(note => note.Title).ToList();
            //else if (title != "" && !work && school && !personal) // (1, 0, 1, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "School" && note.Title == title).Select(note => note.Title).ToList();
            //else if (title != "" && !work && !school && personal) // (1, 0, 0, 1)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Personal" && note.Title == title).Select(note => note.Title).ToList();
            //else if (title == "" && work && school && !personal) // (0, 1, 1, 0)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Work" || note.Category.Name == "School").Select(note => note.Title).ToList();
            //else if (title == "" && work && !school && personal) // (0, 1, 0, 1)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Work" || note.Category.Name == "Personal").Select(note => note.Title).ToList();
            //else if (title == "" && !work && school && personal) // (0, 0, 1, 1)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "School" || note.Category.Name == "Personal").Select(note => note.Title).ToList();
            //else if (title == "" && work && school && personal) // (0, 1, 1, 1)
            //    lstNotesList.DataSource = noteList.Where(note => note.Category.Name == "Work" || note.Category.Name == "School" || note.Category.Name == "Personal").Select(note => note.Title).ToList();
            //else
            //    lstNotesList.DataSource = noteList.Where(note => note.Title == title && note.Category.Name == "Work" || note.Category.Name == "School" || note.Category.Name == "Personal").Select(note => note.Title).ToList();
        }

        private void ClearEditArea()
        {
            txtTitle.Clear();
            txtDescription.Clear();
        }

        private void GetAllNotes()
        {
            lstNotesList.DataSource = new List<string>();

            List<Note> noteList = db.Notes.OrderByDescending(note => note.CreationTime).ToList();
            lstNotesList.DataSource = noteList.Select(note => note.Title).ToList();
        }

        private void EditSelectedNote()
        {
            var selectedNote = TakeDateOfSelectedNote();
            ;

            string title = txtTitle.Text;
            string description = txtDescription.Text;

            selectedNote.Title = title;
            selectedNote.Description = description;
            selectedNote.ModifiedTime = DateTime.Now;

            db.SaveChanges();
        }

        private void CreateBlankNote()
        {
            var newNote = new Note() 
            {
                Title = "Untitled",
                Description = null,
            };

            db.Notes.Add(newNote);
            db.SaveChanges();
        }

        private void RemoveSelectedNote()
        {
            var selectedNote = TakeDateOfSelectedNote();

            if (selectedNote != null)
            {
                db.Notes.Remove(selectedNote);
                db.SaveChanges();
            }
        }

        private Note TakeDateOfSelectedNote()
        {
            string title = lstNotesList.SelectedItem.ToString();
            return db.Notes.FirstOrDefault(note => note.Title == title);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateBlankNote();
            GetAllNotes();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedNote();
            ClearEditArea();
            GetAllNotes();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditSelectedNote();
            GetAllNotes();
        }

        private void lstNotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearEditArea();

            var selectedNote = TakeDateOfSelectedNote();

            txtTitle.Text = selectedNote.Title;
            txtDescription.Text = selectedNote.Description;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterNotes();
        }
    }
}
