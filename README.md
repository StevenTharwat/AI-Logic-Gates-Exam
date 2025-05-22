# Logic Gates Practice App (WinForms)
small exam helping you to solve and remember logic gates using in simple AI

This Windows Forms application is a simple exam tool to **practice and learn logic gates and propositional logic**, aimed at building foundational understanding for AI and computing concepts.

---

## 🧠 Purpose

This app was designed as a personal project to reinforce logic gate concepts like **AND (`^`)**, **OR (`∨`)**, **NOT (`~`)**, and **De Morgan's Laws**, using a quiz-style interface.

---

## ✨ Features

- Random logic expressions quiz
- Real-time score tracking
- Supports both symbolic equivalences and simplifications
- Learn basic logical identities and transformations for AI

---

## 🚀 How It Works

- A random logic question is shown from a predefined list.
- You type the correct simplified or equivalent expression.
- The app checks your answer and updates your score:
  - ✅ Correct: score +1
  - ❌ Incorrect or Skipped: score -1

---

## ✅ Logical Rules Covered

- Basic logic operations:
  - `P ∨ T = T`, `P ^ F = F`, `P ^ T = P`, etc.
- Commutative rules:
  - `p ∨ q = q ∨ p`, `p ^ q = q ^ p`
- Associative and distributive laws
- De Morgan’s Laws:
  - `~(p ∨ q) = ~p ^ ~q`
  - `~(p ^ q) = ~p ∨ ~q`
  
---

## 🛠 How to Run

1. Open the `.sln` file in **Visual Studio**.
2. Press `F5` or click **Start** to run the application.

No external libraries are needed — just .NET 6+ and WinForms.

---

## 💡 Future Ideas

- Add truth table visualizer
- Timer-based challenges
- More advanced logic (XOR, implication)
- Save and review mistakes
