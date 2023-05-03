import './App.css';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import BlogLayout from './layouts';
import Link from './pages/link';
import Home from './pages/home';
import Repository from './pages/repository';
import Blog from './pages/blog';
import About from './pages/about';

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
      {
        path: "/about",
        element: <About/>,
      },
    ]
  },{
    path: "/blog",
    element: <Blog />,
  }
]);

function App() {
  return (
    <RouterProvider router={router} />

  );
}

export default App;
