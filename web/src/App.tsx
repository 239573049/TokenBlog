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
import Ide from './pages/ide';
import Manage from './pages/manage';
import Login from './pages/login';
import ManageHome from './pages/manage/home';
import ManageBlog from './pages/manage/blog';

const router = createBrowserRouter([
  {
    path: "/",
    element: <BlogLayout />,
    children: [
      {
        path: "/",
        element: <Home />,
      },
      {
        path: "/links",
        element: <Link />,
      },
      {
        path: "/repository",
        element: <Repository />,
      },
      {
        path: "/about",
        element: <About />,
      },
    ]
  }, {
    path: "/blog",
    element: <Blog />,
  }, {
    path: "/web-ide",
    element: <Ide />,
  }, {
    path: "/manage",
    element: <Manage />,
    children:[
      {
        path: "/manage",
        element: <ManageHome />,
      },{
        path: "/manage/blog",
        element: <ManageBlog />,
      }
    ]
  }, {
    path: "/login",
    element: <Login />
  }
]);

function App() {
  return (
    <RouterProvider router={router} />

  );
}

export default App;
