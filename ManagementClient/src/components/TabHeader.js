import React from 'react';
import PropTypes from 'prop-types';
import { NavLink } from 'react-router-dom';

const TabHeader = ({Headers}) => (
  <div>
    {Headers.map((h) => <NavLink to={h}>{h}</NavLink>)}
  </div>
);

TabHeader.propTypes = {
  Headers: PropTypes.arrayOf(PropTypes.string).isRequired
};
 

export default TabHeader;

