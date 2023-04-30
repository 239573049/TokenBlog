import './App.css';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import BlogLayout from './layouts';
import Link from './pages/link';
import Home from './pages/home';
import Repository from './pages/repository';

const router = createBrowserRouter([
  {
    path: "/",
    element: <BlogLayout />,
    children: [
      {
        path: "/",
        element: <Home/>,
      },
      {
        path: "/links",
        element: <Link/>,
      },
      {
        path: "/repository",
        element: <Repository/>,
      },
    ]
  }
]);

function App() {
  return (
    <RouterProvider router={router} />

  );
}

export default App;
