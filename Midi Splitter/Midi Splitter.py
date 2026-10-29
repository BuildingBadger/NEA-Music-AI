import os
import mido
from mido import MidiFile
import glob

def extract_all_notes(midi_file_path, num_notes=17):
    try:
        all_notes = []
        midi = MidiFile(midi_file_path)
        for track in midi.tracks:
            notes = []
            for msg in track:
                if msg.type == 'note_on':
                    notes.append(msg.note)
                    if len(notes) >= num_notes:
                        all_notes.append(notes[:num_notes])
                        notes = notes[1:]  # Shift to the next set of notes
                        while len(notes) >= num_notes:  # Extract overlapping notes
                            all_notes.append(notes[:num_notes])
                            notes = notes[1:]
        
        return all_notes
    except mido.KeySignatureError as e: 
        print(e)
        return []

folder_path = ''  # Replace with the path to your folder containing MIDI files
num_notes_to_extract = 17

midi_files = glob.glob(os.path.join(folder_path, '*.mid'))[:-1]
noteChunks = []
save_path = r"C:\Users\benjo\OneDrive\Documents\NEA\Split Files"
fileName = os.path.join(save_path, "Notes.wav")         

f = open(fileName, 'w+')
    
for midi_file_path in midi_files:
    print(f"Sequential Notes from {os.path.basename(midi_file_path)}:")
    all_notes = extract_all_notes(midi_file_path, num_notes_to_extract)
    
    
    for chunk in all_notes:
        
        f.write(str(chunk) + '\n')
        
        #print(str(chunk))
    
    

##noteChunks += all_notes

##print(len(all_notes))
f.close()
os.startfile("Notes.txt")
print("done")
##print(len(noteChunks))