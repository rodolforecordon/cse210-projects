### Journal

#### Attributes
_entries : List<Entry>

#### Methods
AddEntry(newEntry : Entry) : void
DisplayAll() : void
SaveToFile(file : string) : void
LoadFromFile(file : string) : void

---

### Entry

#### Attributes
_date : string
_promptText : string
_entryText : string

#### Methods
Display() : void

---

### PromptGenerator

#### Attributes
_prompts : List<string>

#### Methods
GetRandomPrompt() : string