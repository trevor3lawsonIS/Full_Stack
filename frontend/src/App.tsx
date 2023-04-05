import React from "react";
import "./App.css";
import Header from "./Header";
import FoodList from "./food/FoodList";

function App() {
  return (
    <div className="App">
      <Header slogan="Man, this is a cool first slogan"></Header>
      <FoodList></FoodList>
    </div>
  );
}

export default App;
