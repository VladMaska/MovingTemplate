# 🕹️ MovingTemplate

**MovingTemplate** is a Unity project demonstrating the use of the **Strategy Design Pattern** to implement flexible and interchangeable object movement behaviors

---

## 🧠 What Pattern Is Used?
This is a clear Strategy Pattern implementation:

- PlayerMove is the Strategy Interface (abstract base class), and each movement direction—ForwardMove, LeftMove, BackMove, RightMove—is a Concrete Strategy providing specific movement behavior

- The Player class acts as the Context, holding references to multiple strategies and executing them in Update()

---

## 📂 Design Structure
```csharp
abstract class PlayerMove
    └── defines Move() and Execute()

Concrete Strategies:
    ├── ForwardMove
    ├── LeftMove
    ├── BackMove
    └── RightMove

Context (Player : MonoBehaviour, IPlayerMove)
    ├── Holds four PlayerMove references (Forward, Left, Back, Right)
    ├── Instantiates each in Start()
    └── Calls Move() on each in Update()
```

---

## 🔧 How It Works
- Each Move() implementation checks for its assigned key (W/A/S/D):
    - On key down: triggers Execute() to activate animator boolean.
    - While held: translates the player by a direction vector.
    - On key up: resets the animator parameter.

- The MoveSpeed is centralized as a protected constant in the base class.
- This design promotes composition over inheritance, and aligns with the Open‑Closed Principle—you can add more movement types without modifying the Player class

---

## ✅ Pros & Potential Enhancements

✅ Pros
- Clean separation of behaviors.
- No long if/switch chains inside the controller.
- Easy to add new behaviors (e.g. diagonal or jump move) by implementing a new subclass.

💡 Suggestions
- Optionally allow runtime behavior swapping—e.g. disable left movement.
- Consider injecting a central controller or input-mapper rather than each strategy checking input.
- Factor animator parameter strings into configuration or enums to avoid mismatches.
- Add shared data (like MoveSpeed) to context for easier tuning.
- For more flexibility, consider a dictionary-based lookup rather than four fixed properties.

---

## 📋 Summary Table
| Role     | Class                           | Responsibility                    |
| -------- | ------------------------------- | --------------------------------- |
| Strategy | `PlayerMove`                    | Declares `Move()` and `Execute()` |
| Concrete | `ForwardMove`, `LeftMove`, etc. | Implements directional logic      |
| Context  | `Player`                        | Holds strategies; delegates calls |
