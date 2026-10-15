# The Class Cheat Sheet

### One shared repository. The rest of the semester to build it.

Welcome to our class cheat sheet repository!

This repository is yours to build throughout the rest of the semester. Think of it as a **shared, student-created reference guide** filled with the information you actually want at your fingertips during a test.

## The Deal

**Anything you add to this repository can be used as a reference on future tests and exams for the rest of the semester.**

That includes:

- Notes and explanations in your own words
- Code snippets and working examples
- Syntax references and useful commands
- Formulas, diagrams, tables, and quick-reference guides
- Worked practice problems and step-by-step solutions
- Common errors, debugging tips, and troubleshooting notes
- Links between topics, study guides, and anything else that helps you understand the material

**This is a collaborative cheat sheet.** Everyone in the class can use the material contributed by everyone else. The better you make it together, the more useful it becomes for all of you.

There is no need to keep your notes short. Make them **clear, searchable, and useful**.

## How to Contribute

You will be added to this GitHub repository so you can contribute directly.

1. **Find something worth remembering.** Choose a concept, example, explanation, or solution that might help you on a future exam.
2. **Add or update a file.** Use Markdown (`.md`) for notes, or the appropriate file type for code examples and other resources.
3. **Put it where others can find it.** Use a descriptive file name and an appropriate folder. Create a folder if needed.
4. **Explain what you're adding.** For code, include what it does, when to use it, and any pitfalls. For notes, add examples when possible.
5. **Commit and push your changes.** Use a meaningful commit message so everyone can understand what you added.

You can use GitHub's website to edit files, or clone the repository and work locally using Git and your preferred editor.

### Example: Using Git

```bash
# Clone the repository (replace with our actual repository URL)
git clone <repository-url>

# Open the folder
cd <repository-folder>

# After editing or adding files:
git add .
git commit -m "Add notes on methods and parameter passing"
git push
```

If the repository requires pull requests, create a branch, push that branch, and open a pull request instead of pushing to the main branch.

## Suggested Organization

You can expand or change the structure as our cheat sheet grows.

```text
.
├── README.md
├── notes/
│   ├── topic-name.md
│   └── another-topic.md
├── code-examples/
│   └── example-name/
├── practice-problems/
│   └── worked-examples.md
├── quick-reference/
│   └── common-syntax.md
└── troubleshooting/
    └── common-mistakes.md
```

**Tip:** Give your files names that someone can recognize under exam pressure. `loops-and-conditions.md` is more helpful than `notes2.md`.

## What Makes a Great Entry?

A useful entry answers a question quickly, then gives enough detail to apply the answer.

For example:

````markdown
# Topic: Methods

## When would I use this?
Use a method when a piece of logic needs a clear name or may be reused.

## Example (C#)
```csharp
static int Add(int a, int b)
{
    return a + b;
}

int result = Add(3, 4); // 7
```

## Remember
- Parameters are the variables declared by the method.
- Arguments are the values passed when calling it.
- `return` sends a result back to the caller.
````

You don't have to follow that exact format. The goal is to make each contribution understandable and practical.

## Ground Rules

- **Contribute useful material.** Organize it so classmates can actually find and understand it.
- **Check your work.** If a code snippet is supposed to run, test it when possible. Fix mistakes you find, even in someone else's notes.
- **Respect others' work.** Improve entries instead of deleting useful explanations without a reason.
- **Credit sources.** If you adapt material from documentation, an article, or another resource, include a source link. Don't upload copyrighted books, answer keys, or other material you don't have permission to share.
- **Keep exam questions and answers out of the repo.** Do not upload content from a current, unreleased, or restricted test or exam.
- **Do not upload personal information, passwords, access tokens, or other secrets.**

## Using This During Exams

You may refer to the material in this repository on **future tests and exams throughout the rest of the semester**.

A few important distinctions:

- The **shared repository** is the permitted reference. You may use other students' contributions as well as your own.
- Permission to use the repo does **not** automatically grant permission to use AI assistants, other websites, messaging classmates, or other outside resources during an exam.
- Any specific instructions about accessing or editing the repository during an exam will be provided with that exam.

## The Challenge

Build the reference you wish you had on your last test.

Don't just copy definitions. Add the examples, shortcuts, explanations, and common mistakes that will help you solve problems independently. If something confused you during a lecture or assignment, there's a good chance someone else will benefit from your explanation.

**The time you spend building this repository now is preparation you get to bring with you into every remaining exam.**
