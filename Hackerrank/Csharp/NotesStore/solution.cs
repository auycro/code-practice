using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{
    public class NotesStore
    {
        public enum StateType {completed, active, others}
        
        public class Note{
            public StateType State;
            public string Name;
            
            public Note(StateType state, string name){
                this.Name = name;
                this.State = state;
            }
        }
        
        List<Note> notes;
        public NotesStore() {
            notes = new List<Note>();
        }
        
        public void AddNote(String state, String name) {
            if (string.IsNullOrEmpty(name)){
                throw new Exception("Name cannot be empty");
            }
            
            StateType state_type;
            try {
                state_type = (StateType) Enum.Parse(typeof(StateType), state);
            } catch {
                throw new Exception($"Invalid state {state}");
            }
            
            notes.Add(new Note(state_type, name));
        }
        public List<String> GetNotes(String state) {
            List<string> result = new List<string>();
            
            StateType state_type;
            try {
                state_type = (StateType) Enum.Parse(typeof(StateType), state);
            } catch {
                throw new Exception($"Invalid state {state}");
            }
            
            notes.ForEach(x => {
                if (x.State == state_type){
                    result.Add(x.Name);
                }
            });
            
            return result;
        }
    } 

    public class Solution
    {
        public static void Main() 
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++) {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    } else {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}