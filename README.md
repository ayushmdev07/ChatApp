# Chatrr 💬

Chatrr is a modern **real‑time web chat application** built with **ASP.NET Core** and **SignalR**, featuring a clean mobile‑style UI, user join modal, and live group messaging.

---

## 🚀 Features

* 🔴 **Real‑time messaging** using SignalR
* 👤 **Username-based joining system** (required to enter chat)
* 👥 **Group chat support**
* 📢 **User join / leave notifications**
* 🕒 **Message timestamps (AM/PM)**
* 📱 **Mobile‑first modern UI**
* 🎨 **Tailwind CSS + Flowbite UI**
* 🔔 **SweetAlert2 alerts & toast notifications**
* 🔄 **Auto reconnect support**

---

## 🛠 Tech Stack

### Frontend

* HTML5 / Razor Views
* Tailwind CSS
* Flowbite
* JavaScript
* SweetAlert2

### Backend

* ASP.NET Core
* SignalR (WebSockets)

---

## 📂 Project Structure (Simplified)

```
/Views
 └── Home
     └── Index.cshtml   # Chat UI & client logic
/Hubs
 └── ChatHub.cs         # SignalR hub (Join, Leave, SendMessage)
/wwwroot
 └── css / js
```

---

## ⚙️ How It Works

1. User opens the app
2. **Name input modal** appears (cannot be skipped)
3. User enters name and joins chat
4. SignalR establishes WebSocket connection
5. Messages are broadcasted in real‑time
6. Join/Leave events are shown in chat

---

## 🧪 Running the Project

### Prerequisites

* .NET SDK 7 or later
* Visual Studio / VS Code

### Steps

```bash
dotnet restore
dotnet run
```

Open browser:

```
https://localhost:xxxx
```

---

## 🔐 SignalR Hub Methods

* `Join(string user)`
* `Leave(string user)`
* `SendMessage(string user, string message)`

---

## ✨ UI Highlights

* Chat bubbles align **left/right** based on sender
* Gradient chat container
* Smooth scrolling messages
* Disabled chat until user joins

---

## 📌 Future Improvements

* ✅ Private chat rooms
* 🔐 Authentication
* 🗂 Chat history storage
* 📎 File & emoji support
* 👀 Online users list

---

## 📸 Screenshots



---

## 📄 License

This project is open‑source and free to use for learning purposes.

---

## 🙌 Author

**Ayush Maurya**

> Built with ❤️ using ASP.NET Core & SignalR
